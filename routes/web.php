<?php

use Illuminate\Support\Facades\Route;
use App\Models;
use App\Models\Speciality;
use App\Models\User;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('index');
});

Route::get('prueba', function(){
    // $user =new User();
    // $user->name="Eduardo Natalio";
    // $user->surname="Pacompia";
    // $user->username="epacompia";
    // $user->password='123456';
    // $user->email='eduardopacompia@gmail.com';
    // $user->is_active=true;

    // $user->save();
    // return $user;

    /*
    $data= [
        'name'=>"test 1.1",
        'description'=>"test 2.2",
        'flag'=>false
    ];

    //asigncaion masiva (aprovechando los valores del formulario $data)
    $speciality=Speciality::create($data);

    return $speciality;
    */

    /*
    //2°forma asignacion masiva para actualizar registro
    $data=[
        'name'=>'Mayimbu',
        'surname'=>'Meeee'
    ];

    $user=User::find(1);
    $user->update($data);
    return $user;
    */
    /*
    //1° forma usando el modelo User
    $user=User::find(1);
    $user->name="jose manuel";
    $user->save();
    return $user;
    */

    //Eliminar registro
    $user=User::find(40);
    $user->delete();
    return "Eliminado";

});