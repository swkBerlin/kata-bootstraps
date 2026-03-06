#include "kata.hpp"
#include <gmock/gmock.h>

using ::testing::Eq;

TEST(KataTest, passing)
{
    SUCCEED();
}

TEST(KataTest, life_the_universe_and_everything)
{
    ASSERT_THAT(Kata::answer(), Eq(42));
}
