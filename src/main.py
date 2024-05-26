import random


def choose_door(doors, chosen_door, remaining_unopened_door, switch_doors):
    if switch_doors:
        return doors[remaining_unopened_door] == 1
    else:
        return doors[chosen_door] == 1


def remaining_door(chosen_door, host_goat_door):
    for door in range(3):
        if door != chosen_door and door != host_goat_door:
            return door


class MontyHallSimulator:
    def __init__(self):
        self.random_generator = random

    def simulate(self, iterations, switch_doors):
        doors = [0, 0, 0]  # 0 = goat, 1 = car
        win_count = 0

        for _ in range(iterations):
            self.place_prizes(doors)
            chosen_door = self.guess_door()
            host_goat_door = self.host_door(doors, chosen_door)
            remaining_unopened_door = remaining_door(chosen_door, host_goat_door)
            win = choose_door(doors, chosen_door, remaining_unopened_door, switch_doors)

            if win:
                win_count += 1

        return win_count / iterations

    def place_prizes(self, doors):
        car_door = self.random_generator.randint(0, 2)
        for door_number in range(3):
            if door_number == car_door:
                doors[door_number] = 1
            else:
                doors[door_number] = 0

    def guess_door(self):
        return self.random_generator.randint(0, 2)

    def host_door(self, doors, chosen_door):
        if doors[chosen_door] == 1:
            goat_doors = [door for door in range(3) if door != chosen_door]
            return self.random_generator.choice(goat_doors)
        else:
            return [door for door in range(3) if doors[door] == 0 and door != chosen_door][0]


if __name__ == "__main__":
    monty_hall = MontyHallSimulator()
    simulation_iterations = 10000
    for change_doors in [True, False]:
        win_rate = monty_hall.simulate(simulation_iterations, change_doors)
        print(f"{'Switching' if change_doors else 'Keeping'} doors win rate after {simulation_iterations} iterations: "
              f"{round(win_rate * 100)}%")
