<?php
error_reporting(0);



// array for JSON response
$response = array();

$sql = "SELECT *FROM logindata";
require_once('db_config.php');
// get all items from myorder table

$result = mysqli_query($con,$sql) or die(mysqli_error());

if (mysqli_num_rows($result) > 0) {
  
    $response["accounts"] = array();

    while ($row = mysqli_fetch_array($result)) {
            // temp user array
            $item = array();
            $item["id"] = $row["idlogindata"];
            $item["user_name"] = $row["user_name"];
            $item["password"] = $row["password"];
        
            // push ordered items into response array 
            array_push($response["accounts"], $item);
           }
      // success
     $response["success"] = 1;
}
else {
    // order is empty 
      $response["success"] = 0;
      $response["message"] = "No Items Found";
}
mysqli_close($con);
// echoing JSON response
echo json_encode($response);

?>