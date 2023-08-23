<?php

namespace Database\Seeders;

use App\Models\User;

use Faker\Provider\nl_NL\Person;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

class DatabaseSeeder extends Seeder
{
    /**
     * Seed the application's database.
     *
     * @return void
     */
    public function run()
    {
        // \App\Models\Person::factory(50)->create()->each(function ($person) {
        //     User::factory()->create([
        //         'person_id'=>$person->id,
        //     ]);
        //  });


        \App\Models\Cip_status::factory(4)->create();
         \App\Models\Speciality::factory(50)->create();
         \App\Models\Civil_status::factory(5)->create();
         \App\Models\Ubigeo::factory(100)->create();
         \App\Models\Psychosomatic_aptitud::factory(10)->create();
         \App\Models\Degree::factory(200)->create();




    }
}
