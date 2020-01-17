from collections import deque

line = input().split(' ')
num = int(input())

names = deque(line)
index = 0

while names:
    person = names.popleft()
    index += 1
    if index == num:
        index = 0
        if names:
            print(f'Removed {person}')
        else:
            print(f'Last is {person}')
    else:
        names.append(person)