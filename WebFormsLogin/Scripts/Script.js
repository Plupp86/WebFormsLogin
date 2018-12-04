//$(document).ready(function () {




//	function toggleLogin() {
//		//let loginDiv = document.getElementById('sn-login');
//		//loginDiv.style.display = "block";
//		let loginDiv = $('#sn-login');
//		loginDiv.style.height = "130px";
//		loginDiv.style.transform = "translate(00%, 160px)";
//	}


//});





$(document).ready(function () {
	$("#loggedOut").click(function () {
		$('#snlogin').fadeToggle();
	});
});
