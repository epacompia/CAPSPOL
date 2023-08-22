<?php

namespace Database\Factories;

use Illuminate\Database\Eloquent\Factories\Factory;
use Illuminate\Support\Str;
use App\Models\User;

class UserFactory extends Factory
{
    protected $model = User::class;

    public function definition()
    {
        return [
            'name' => $this->faker->name(),
            'surname' => $this->faker->lastName(),
            'username' => substr($this->faker->userName(), 0, 12),
            'password' => '$2y$10$92IXUN', // password
            'email' => $this->faker->unique()->safeEmail(),
            'email_verified_at' => now(),
            'is_active' => true, //por defecto verdadero
            'remember_token' => Str::random(10),
        ];
    }

    public function unverified()
    {
        return $this->state(function (array $attributes) {
            return [
                'email_verified_at' => null,
            ];
        });
    }
}
