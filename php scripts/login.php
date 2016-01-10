<?php

	if($_SERVER['REQUEST_METHOD']=='POST'){
		
		$username = $_POST['username'];
		$studentnum = $_POST['studentnum'];
		$password = $_POST['password'];
		
		require_once('db_config.php');

		$sql = "SELECT * FROM users WHERE username='$username' AND password='$password'";

		$result = mysqli_query($con,$sql);
		$check = mysqli_fetch_array($result);

		if(isset($check)){
			echo 'Success';
		}
		else{
			echo 'Login Failed';
		}

	}

	else{
		echo 'error';
	}

?>