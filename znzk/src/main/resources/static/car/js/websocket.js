$.extend({
	websocket:function(type,callback) {
	  	var socket;
		if (!window.WebSocket) {
			window.WebSocket = window.MozWebSocket;
		}
		var domain = document.domain;

		if (window.WebSocket) {
			// ws://"+domain+":9090/ws?type=event// 智能检测
			// ws://"+domain+":9090/ws?type=traffic_warning// 路况预警
			// ws://"+domain+":9090/ws?type=msg_publish// 信息发布
			// ws://"+domain+":9090/ws?type=traffic// 实时路况
			socket = new WebSocket("ws://"+domain+":9090/ws?type="+type);
			socket.onmessage = function(event) {				 
				callback(event);				
			};
			socket.onopen = function(event) {
				console.log("打开websocket服务正常");
			}
			socket.onclose = function(event) {
				console.log("websocket关闭");
			}
		} else {
			alert("对不起，您的浏览器不支持WebSocket.");
		}

		return socket;
	}
});