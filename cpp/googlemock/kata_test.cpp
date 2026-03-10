#include "kata.hpp"
#include "mock_logger.hpp"
#include <gmock/gmock.h>

using namespace ::testing;

TEST(KataTest, passing)
{
    SUCCEED();
}

TEST(Kata, life_the_universe_and_everything)
{
    MockLogger logger;
    EXPECT_CALL(logger, log("Kata::answer()")).Times(Exactly(1));
    Kata arthur(logger);
    ASSERT_THAT(arthur.answer(), Eq(42));
}

