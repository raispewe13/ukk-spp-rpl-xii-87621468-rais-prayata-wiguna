<?php

namespace App\Models;

use Illuminate\Contracts\Auth\Guard;
use Illuminate\Database\Eloquent\Attributes\Fillable;
use Illuminate\Database\Eloquent\Attributes\Guarded;
use Illuminate\Database\Eloquent\Model;
use Override;

class Petugas extends Model
{
    //
    protected $fillable = [
        'id_petugas',
        'username',
        'password',
        'nama_petugas',
        'level'
    ];
}
