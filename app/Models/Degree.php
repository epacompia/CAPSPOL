<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Degree extends Model
{
    use HasFactory;

    protected $fillable=[
        'grade',
        'description',
        'flag',
    ];

    protected $table='degrees';


    protected $hidden=[];

}
