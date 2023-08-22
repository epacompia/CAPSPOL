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


        \App\Models\Person::factory(10)->create();
         \App\Models\Speciality::factory(50)->create();

    }
}
