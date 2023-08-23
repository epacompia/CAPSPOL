<?php

namespace Database\Factories;

use Illuminate\Database\Eloquent\Factories\Factory;

/**
 * @extends \Illuminate\Database\Eloquent\Factories\Factory<\App\Models\Degree>
 */
class DegreeFactory extends Factory
{
    /**
     * Define the model's default state.
     *
     * @return array<string, mixed>
     */
    public function definition()
    {
        return [
            'grade' =>$this->faker->randomElement(['Gral.','Crnel.','Cmdate.','May.','Cap.','Alf.','Sup.','ST1','ST2','ST3','S1','S2','S3'])
        ];
    }
}
