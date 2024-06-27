<?php

declare(strict_types=1);

namespace Tests;

use PHPUnit\Framework\TestCase;

class FailingTest extends TestCase
{
    public function testMultiplyByZero()
    {
        $this->assertEquals(0, 1);
    }
}