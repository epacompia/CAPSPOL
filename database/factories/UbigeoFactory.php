<?php

namespace Database\Factories;

use Illuminate\Database\Eloquent\Factories\Factory;

/**
 * @extends \Illuminate\Database\Eloquent\Factories\Factory<\App\Models\Ubigeo>
 */
class UbigeoFactory extends Factory
{
    /**
     * Define the model's default state.
     *
     * @return array<string, mixed>
     */
    public function definition()
    {
        return [
            //
            'department' =>$this->faker->word(),
            'province' => $this->faker->word(),
            'district' => $this->faker->word(),
        ];
    }
}
