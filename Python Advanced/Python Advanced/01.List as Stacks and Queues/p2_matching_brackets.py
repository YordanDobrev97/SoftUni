from stack import Stack
expression = input()

st = Stack()

for index in range(len(expression)):
    val = expression[index]
    if val == '(':
        st.push(index)
    elif val == ')':
        last_index = st.pop()
        sub_expression = expression[last_index: index + 1]
        print(sub_expression)
