<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('persons', function (Blueprint $table) {
            $table->id();
            $table->string('name',50);
            $table->string('surname',50);
            $table->string('father_surname',50);
            $table->string('mother_surname',50);
            $table->enum('sex_id',['m','f']);
            $table->string('address', 70)->nullable();
            $table->char('dni', 8)->unique();
            $table->char('cip', 10)->unique();
            $table->unsignedBigInteger('cip_status_id');
            $table->string('mobile', 9)->nullable();
            $table->string('phone', 10)->nullable();
            $table->date('date_of_born');
            $table->string('email', 50);
            $table->string('personal_email', 50);
            $table->unsignedBigInteger('civil_status_id');
            $table->date('last_ascent')->nullable();
            $table->integer('scale');
            $table->unsignedBigInteger('ubigeo_id');
            $table->unsignedBigInteger('psychosomatic_aptitude_id');
            $table->string('address_reference', 200)->nullable();
            $table->enum('modality', ['a', 'o'])->nullable();
            $table->unsignedBigInteger('degree_id');
            $table->unsignedBigInteger('position_id');
            $table->unsignedBigInteger('sub_unit_id');
            $table->unsignedBigInteger('speciality_id');
            $table->unsignedBigInteger('police_station_id');
            $table->string('legal_situation_name',100)->nullable();
            $table->date('legal_situation_date');
            $table->text('legal_situation_obs');
            $table->timestamps();

            // LLAVES FORANEAS
            $table->foreign('cip_status_id')->references('id')->on('cip_statuses')->onDelete('cascade');;
            $table->foreign('civil_status_id')->references('id')->on('civil_statuses')->onDelete('cascade');;
            $table->foreign('ubigeo_id')->references('id')->on('ubigeos')->onDelete('cascade');;
            $table->foreign('psychosomatic_aptitude_id')->references('id')->on('psychosomatic_aptitudes')->onDelete('cascade');;
            $table->foreign('degree_id')->references('id')->on('degrees')->onDelete('cascade');;
            $table->foreign('position_id')->references('id')->on('positions')->onDelete('cascade');;
            $table->foreign('sub_unit_id')->references('id')->on('sub_units')->onDelete('cascade');;
            $table->foreign('speciality_id')->references('id')->on('specialties')->onDelete('cascade');;
            $table->foreign('police_station_id')->references('id')->on('police_stations')->onDelete('cascade');;

        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('persons');
    }
};
