#define DOCTEST_CONFIG_IMPLEMENT_WITH_MAIN
#include "doctest.h"

class GameOfLife
{
    public:
        GameOfLife() = default;

        bool isReady() { return true; }
};

TEST_CASE("checkGameOfLifeGoodInitialization")
{
    GameOfLife game{};
    CHECK(game.isReady() == true);
}