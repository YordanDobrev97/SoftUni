from collections import deque
my_queue = deque()

while True:
    command = input()
    if command == "End":
        break

    if command == "Paid":
        print()
        while my_queue:
            print(my_queue.popleft())
    else:
        my_queue.append(command)

print(f'{len(my_queue)} people remaining.')