<?php
$errors = array();
$data = array();

if (empty($_POST['imie']))
        $errors['imie'] = 'Imie is required.';

if (empty($_POST['nazwisko']))
        $errors['nzawisko'] = 'Nzawisko is required.';

if (empty($_POST['nazwisko']))
        $errors['nzawisko'] = 'Nzawisko is required.';

if ( ! empty($errors)) {
        $data['success'] = false;
        $data['errors']  = $errors;
    } else {
        $data['success'] = true;
        $data['message'] = 'Success!';
    }
    echo json_encode($data);
?>