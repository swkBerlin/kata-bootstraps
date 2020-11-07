import unittest
from parameterized import parameterized

def mutation(alive_neighbours, current_cell_state):
    return current_cell_state and alive_neighbours == 2 or alive_neighbours == 3

class TodoProjectNameTestCase(unittest.TestCase):
    @parameterized.expand([
        ["underpopulation_1", 1, False],
        ["underpopulation_smaller_1", 0, False],
        ["overcrowding", 4, False],
        ["overcrowding_bigger_4", 5, False],
        ["stay_alive", 2, True],
        ["stay_alive_3", 3, True]
    ])
    def test_mutation_of_alive_cell(self, name, alive_neighbours, cell_is_alive):
        cell_state_after_mutation = mutation(alive_neighbours, True)
        self.assertEqual(cell_state_after_mutation, cell_is_alive)


    @parameterized.expand([
        ["underpopulation_1", 1, False],
        ["underpopulation_smaller_1", 0, False],
        ["overcrowding", 4, False],
        ["overcrowding_bigger", 5, False],
        ["stay_dead", 2, False],
        ["resurrection", 3, True]
    ])
    def test_mutation_of_dead_cell(self, name, alive_neighbours, cell_is_alive):
        cell_state_after_mutation = mutation(alive_neighbours, False)
        self.assertEqual(cell_state_after_mutation, cell_is_alive)


if __name__ == '__main__':
    unittest.main()
