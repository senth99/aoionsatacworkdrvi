Implement an RPN calculator that takes an expression like 19 2.14 + 4.5 2 4.3 / - * which is usually expressed as (19 + 2.14) * (4.5 - 2 / 4.3) and responds with 85.2974. The program should read expressions from standard input and print the top of the stack to standard output when a newline is encountered. The program should retain the state of the operand stack between expressions.


PSUEDO CODE:
iterate over input characters:
	if character is an operator
		push to stack
	vector<char> expression
	while stack is not empty
		expression.Add(pop stack)
	expression.Add(character)
	evaluate(expression)
