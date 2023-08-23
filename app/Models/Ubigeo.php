<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Ubigeo extends Model
{
    use HasFactory;

    protected $fillable=[
        'department',
        'province',
        'district',
    ];

    protected $table='ubigeos';

    protected $hidden=[

    ];
}