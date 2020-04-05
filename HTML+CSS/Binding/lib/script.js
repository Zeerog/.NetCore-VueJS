function binder(elem, model, paramName){
  let domParamName="dom" + paramName
  let _paramName="_" + paramName
  Object.defineProperty(model, paramName, {
    set : function (value) {
      this[_paramName] = value;
      elem.value = value;
      },
    get : function () {return this[_paramName]}
  });
  Object.defineProperty(model, [domParamName], {
    set : function (value) {
      this[_paramName] = value}
  });
  elem.onchange = function(){
    model[domParamName] = elem.value
  }
}

pricing = {
  "studio": 10,
  "1bed": 15,
  "2bed": 20
}

let model = {
  days: "",
  room: "",
  sum: 0
}

function calc() {
  if(model.days && model.room) {
    if(pricing[model.room]) {
      model.sum = pricing[model.room] * model.days;
    }
    else 
      model.sum=0
  }
  else 
    model.sum=0
}

document.onchange=function(){
  calc()
  sum.value = model.sum
}

setTimeout(function(){
binder(days, model, "days")
binder(room, model, "room")
binder(sum, model, "sum")
},0)