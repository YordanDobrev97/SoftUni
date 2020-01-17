from collections import deque

litters = int(input())

persons = deque()
while True:
    line = input()

    if line == "Start":
        break
    persons.append(line)

print()
while persons:
    line = input()
    if line == "End":
        break

    items = line.split(' ')
    if items[0] == "refill":
        add_litters = int(items[1])
        litters += add_litters
    else:
        person = persons.popleft()
        li = items[0]
        sub_litters = int(li)

        if sub_litters <= litters:
            litters -= sub_litters
            print(f'{person} got water.')
        else:
            print(f'{person} must wait.')

print(f'{litters} liters left.')
