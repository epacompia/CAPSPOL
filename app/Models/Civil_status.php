<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Civil_status extends Model
{
    use HasFactory;

    protected $fillable=[
        'name',
    ];

    protected $table='civil_statuses';

    protected $hidden=[

    ];


}