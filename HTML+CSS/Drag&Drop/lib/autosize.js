document.onpaste=document.onkeydown=function(event) {
    let target = event.target.closest('textarea')
    if (!target) return;
    setTimeout(resize, 0, target);
}
function resize (elem) {
    elem.style.height = 'auto';
    if(elem.scrollHeight>35)
    elem.style.height = elem.scrollHeight-5+'px';
    else
    elem.style.height = 35+'px';
}