<?php
 
	if($_SERVER['REQUEST_METHOD']=='POST'){
		
		$username = $_POST['username'];
		$studentnum = $_POST['studentnum'];
		$password = $_POST['password'];
		
		require_once('db_config.php');

		$sql = "INSERT INTO users (studentnum,username,password) VALUES ('$studentnum','$username','$password')";
		$check = "SELECT * FROM users WHERE studentnum='$studentnum'";
		$usercheck = mysqli_query($con,$check) or die ('error');
		$checkrow = mysqli_num_rows($usercheck);
		if($checkrow > 0){
			echo 'Student number is already registered!';
		}
		else{
			$check = "SELECT * FROM users WHERE username='$username'";
			$usercheck = mysqli_query($con,$check) or die ('error');
			$checkrow = mysqli_num_rows($usercheck);
			if($checkrow > 0){
				echo 'Username is already registered!';
			}
			else{
				if(mysqli_query($con,$sql)){
					echo "Successfully Registered";
				}
				else{
					echo "Could not register";
				}
			}
		}
	}
	else{
		echo 'error';
	}
?>