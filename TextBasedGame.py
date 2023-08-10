def show_instructions():
    print("Text-Based Adventure Game")
    print("Your goal is to collect all items before encountering the villain.")
    print("Move commands: go North, go South, go East, go West")
    print("Add to Inventory: get 'item name'")
    print("Show Available Directions: where can I go")
    print("----------------------")

def display_status(room, inventory, item):
    print("You are in the", room)
    print("Inventory:", inventory)
    if item:
        print("You see a", item)
    print("----------------------")
    print("Enter your move:")

def show_available_directions(room):
    print("Available directions:")
    for direction in rooms[room]:
        if direction != 'item':
            print(direction.capitalize())

def main():
    current_room = 'Start'
    inventory = []

    show_instructions()

    while True:
        display_status(current_room, inventory, rooms[current_room]['item'])
        command = input().lower()

        if command == 'where can i go':
            show_available_directions(current_room)

        if command.startswith('go '):
            direction = command[3:].capitalize()  # Capitalize direction input
            if direction in rooms[current_room]:
                current_room = rooms[current_room][direction]
            else:
                print("You can't go that way!")

        elif command.startswith('get '):
            item_name = command[4:]
            if rooms[current_room]['item'] == item_name:
                inventory.append(item_name)
                rooms[current_room]['item'] = None
                print(f"You obtained {item_name}!")
            else:
                print("There's no such item here.")

        if all(item in inventory for item in ['Key', 'Map', 'Torch']):
            print("Congratulations! You have collected all items and won the game!")
            break

        if current_room == 'Villain Room':
            print("NOM NOM...GAME OVER!")
            break

    print("Thanks for playing the game. Hope you enjoyed it.")

if __name__ == "__main__":
    rooms = {
        'Start': {'North': 'Kitchen', 'item': None},
        'Kitchen': {'South': 'Start', 'East': 'Dining Room', 'item': 'Knife'},
        'Dining Room': {'West': 'Kitchen', 'North': 'Garden', 'item': 'Potion'},
        'Garden': {'South': 'Dining Room', 'item': 'Key'},
        'Villain Room': {'West': 'Dungeon', 'item': 'Map'},
        'Dungeon': {'East': 'Villain Room', 'item': 'Torch'}
    }

    main()
