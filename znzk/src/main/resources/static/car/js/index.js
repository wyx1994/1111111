var websocket=null;
$(function(){
	$('.content').height($(window).height()-$('.header').height());
})


/**
 * 加载放行记录，通过websocket实时推送
 */
function loadRecords() {
	$.ajax({
		type : "POST",
		url : url.alerts,
		success : function(data) {
			if (!!!websocket) {
				websocket = $.websocket("ws://",refreshWSList);
			}

			//TODO 第一次请求的记录反显
		},
		error : function() {
			alert('请求放行记录失败，请重试！')
		}
	});
}

/**
 * 实时加载websocket推送数据 data 新数据
 */
function refreshWSList(data) {
	//TODO 实时加载新数据
}