<?php

declare(strict_types=1);

namespace Tests;

use PHPUnit\Framework\TestCase;
use swkberlin\Kata;

class KataTest extends TestCase
{
    public function testDummy(): void
    {
        $kata = new Kata();
        $this->assertInstanceOf(Kata::class, $kata);
        $this->assertTrue(false);
    }

    public function testNotFailing(): void
    {
        $this->assertTrue(true);
    }
}
