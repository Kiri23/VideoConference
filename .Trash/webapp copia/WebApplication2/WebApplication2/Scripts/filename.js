

function myfunction2() {
    alert("hag form jqueryyyyyyy s")
}


function myfunction() {

    

    var _cc_scriptobj = null;
    var _cc_doc_scripts = document.getElementsByTagName("script");
    var src = "https://embed.clickwebinar.com/embed_conference.html?r=16513797837782".replace(/https?:\/\/embed./, "");
    for (var i = 0; i < _cc_doc_scripts.length; i++) {
        if (_cc_doc_scripts[i].src.toLowerCase().indexOf(src) !== -1) {
            _cc_scriptobj = _cc_doc_scripts[i];
            break;
        }
    }
    if (_cc_scriptobj) {

         
        alert("working ")
        var _cc_obj = document.createElement("iframe");
        _cc_obj.id = "clickmeetingFlashrhrejfhjheuymIframe";
        _cc_obj.src = "https://kpg.clickwebinar.com/175457169?popup=off&lang=en&xlang=";
        _cc_obj.frameBorder = "0";
        _cc_obj.style.border = "none";
        _cc_obj.scrolling = "no";
        _cc_obj.width = "1024";
        _cc_obj.height = "768";
        _cc_obj.style.display = "block";


        if (typeof (__cm_room_width) != "undefined") _cc_obj.width = __cm_room_width;
        if (typeof (__cm_room_height) != "undefined") _cc_obj.height = __cm_room_height;
        _cc_scriptobj.parentNode.insertBefore(_cc_obj, _cc_scriptobj);
        document.body.style.overflowX = "hidden";
    }
    else {
        alert("Meeting doesn't exist!");
    }


}