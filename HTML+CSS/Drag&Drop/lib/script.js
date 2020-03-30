var dragObject = {};
function onMouseDown(e) {
  if (e.which != 1) { 
    return false;
  }
  checkElem(e);

  var elem = e.target.closest('.drag-item');

  if (!elem) return; // не нашли, клик вне draggable-объекта

  // запомнить переносимый объект
  dragObject.elem = elem;

  // запомнить координаты, с которых начат перенос объекта
  dragObject.downX = e.pageX;
  dragObject.downY = e.pageY;
}
document.onmousedown = onMouseDown;

function onMouseMove(e) {
  if (!dragObject.elem) return; // элемент не зажат

  if (!dragObject.avatar) { // если перенос не начат...
    var moveX = e.pageX - dragObject.downX;
    var moveY = e.pageY - dragObject.downY;

    // если мышь передвинулась в нажатом состоянии недостаточно далеко
    if (Math.abs(moveX) < 3 && Math.abs(moveY) < 3) {
      return;
    }
    
    deleteIcon = document.querySelector('.delete');
    deleteIcon.parentNode.removeChild(deleteIcon);

    // начинаем перенос
    dragObject.avatar = createAvatar(e); // создать аватар
    if (!dragObject.avatar) { // отмена переноса, нельзя "захватить" за эту часть элемента
      dragObject = {};
      return;
    }

    // аватар создан успешно
    // создать вспомогательные свойства shiftX/shiftY
    var coords = getCoords(dragObject.avatar);
    dragObject.shiftX = dragObject.downX - coords.left;
    dragObject.shiftY = dragObject.downY - coords.top;

    startDrag(e); // отобразить начало переноса
    
  }

  // отобразить перенос объекта при каждом движении мыши
  dragObject.avatar.style.left = e.pageX - dragObject.shiftX -10 + 'px';
  dragObject.avatar.style.top = e.pageY - dragObject.shiftY -10 + 'px';

  var dropElem = findDroppable(e);
  if (!dropElem) {
    dropZone.parentNode.removeChild(dropZone);
  } else {
    addDropZone(dragObject, dropElem);
  }
  

  return false;
}

function onMouseUp(e) {
  if (dragObject.avatar) { // если перенос идет
    finishDrag(e);
  }
  addItem(e);
  // перенос либо не начинался, либо завершился
  // в любом случае очистим "состояние переноса" dragObject
  dragObject = {};
}

function finishDrag(e) {
  var dropElem = findDroppable(e);
  dragObject.avatar.classList.remove('is-moving');
  if (!dropElem) {
    onDragCancel(dragObject);
  } else {
    onDragEnd(dragObject, dropElem);
  }
}

function createAvatar(e) {
  // запомнить старые свойства, чтобы вернуться к ним при отмене переноса
  var avatar = dragObject.elem;
  avatar.classList.add('is-moving');
  var old = {
    parent: avatar.parentNode,
    nextSibling: avatar.nextSibling,
    position: avatar.position || '',
    left: avatar.left || '',
    top: avatar.top || '',
    zIndex: avatar.zIndex || ''
  };

  // функция для отмены переноса
  avatar.rollback = function() {
    old.parent.insertBefore(avatar, old.nextSibling);
    avatar.style.position = old.position;
    avatar.style.left = old.left;
    avatar.style.top = old.top;
    avatar.style.zIndex = old.zIndex
  };

  avatar.insert = function(dropElem) {
    dropElem.before(avatar);
    dropElem.parentNode.removeChild(dropElem);
    avatar.style.position = old.position;
    avatar.style.left = old.left;
    avatar.style.top = old.top;
    avatar.style.zIndex = old.zIndex
  };
  return avatar;
}

function startDrag(e) {
  var avatar = dragObject.avatar;

  // инициировать начало переноса
  document.body.appendChild(avatar);
  avatar.style.zIndex = 9999;
  avatar.style.position = 'absolute';
}

function findDroppable(event) {
  // спрячем переносимый элемент
  dragObject.avatar.hidden = true;

  // получить самый вложенный элемент под курсором мыши
  var elem = document.elementFromPoint(event.clientX, event.clientY);

  // показать переносимый элемент обратно
  dragObject.avatar.hidden = false;

  if (elem == null) {
    // такое возможно, если курсор мыши "вылетел" за границу окна
    return null;
  }
  return elem.closest('.droppable');
}

function addDropZone(dragObject, dropElem){
  
  dropZone = dropElem.closest('.drop-zone');
  if(dropZone == dropElem)
    return
  dropZone = document.querySelector('.drop-zone');
  if(dropZone){
    dropZone.parentNode.removeChild(dropZone);
  }
  dropZone = document.createElement("textarea");
  dropZone.classList.add('drag-item'); 
  dropZone.classList.add('drop-zone'); 
  dropZone.classList.add('droppable'); 
  dropElem.before(dropZone);
  dropZone.style.height = dragObject.avatar.style.height;
}

function addItem(e){
  dropElem = e.target.closest('.add-button');
  if(dropElem){
    item = document.createElement("textarea");
    item.classList.add('drag-item'); 
    item.classList.add('droppable'); 
    dropElem.before(item);
  }
}

document.onmousemove = onMouseMove;
document.onmouseup = onMouseUp;
document.onmousedown = onMouseDown;

onDragCancel = function(dragObject) {
  dragObject.avatar.rollback();
};

onDragEnd = function(dragObject, dropElem) {
  dragObject.avatar.insert(dropElem);
};

function getCoords(elem) { // кроме IE8-
  var box = elem.getBoundingClientRect();
  return {
    top: box.top + pageYOffset,
    left: box.left + pageXOffset
  };
}