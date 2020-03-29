function positionAt(anchor, elem) {
  let anchorCoords = anchor.getBoundingClientRect();
  elem.style.left = anchorCoords.left + anchor.offsetWidth -20 + "px";
  elem.style.top = anchorCoords.top + "px";
}

function createDeleteIcon(anchor) {
  let note = document.createElement('div');
  note.className = "delete";
  note.innerHTML = "x";
  document.body.append(note);
  positionAt(anchor, note);
}

function checkElem(e){
deleteIcon = document.querySelector('.delete');
if(deleteIcon){
  var elem = e.target.closest('.delete');
  if (elem){
    elem.parentNode.removeChild(elem);
    deleteItem.parentNode.removeChild(deleteItem);
  }
  else{
    deleteIcon = document.querySelector('.delete');
    deleteIcon.parentNode.removeChild(deleteIcon);
  }
}
  var elem = e.target.closest('.drag-item');
  if (elem){
    deleteItem = elem;
    createDeleteIcon(elem);
  }
  var elem = e.target.closest('.drag-column-header');
  if (elem){
    deleteItem = e.target.closest('.drag-column');
    createDeleteIcon(elem);
  }
}