<?php
    if ($_SERVER['REQUEST_METHOD']=='GET'){
    
        $id  = $_GET['id'];

        require_once('Connect.php');

        $sql = "SELECT * FROM SubjectEnrolled WHERE studentnum='".$id."'";

        $r = mysqli_query($con,$sql);

        $res = mysqli_fetch_array($r);

        $result = array();

        array_push($result,array("subject1" => $res['Subject1'],
                            "subject2" => $res['Subject2'],
                            "subject3" => $res['Subject3'],
                            "subject4" => $res['Subject4']));
    
        echo json_encode(array("result"=> $result));

        mysqli_close($con);
     
    }

?>