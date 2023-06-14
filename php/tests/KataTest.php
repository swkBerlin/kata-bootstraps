<?php

declare(strict_types=1);

namespace Tests;

use PHPUnit\Framework\TestCase;
use swkberlin\Kata;

class KataTest extends TestCase
{
    public function testDummy(): void
    {
<<<<<<< HEAD
        $kata = new Kata();
        $this->assertInstanceOf(Kata::class, $kata);
=======
        $kat = new Kata();
>>>>>>> 06f01f1016fb99e97882a042564c4b7539b6b3cd
        $this->assertTrue(false);
    }

    public function testNotFailing(): void
    {
        $this->assertTrue(true);
    }
}
