<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Psychosomatic_aptitud extends Model
{
    use HasFactory;

    protected $fillable=[
        'name',
    ];

    protected $table='psychosomatic_aptitudes';

    protected $hidden=[

    ];
}
