
Prompt _prompt = new Prompt();
_prompt.AddPrompt(new Prompt("What did you have for Lunch?"));
_prompt.AddPrompt(new Prompt("What did you have for Dinner?"));
_prompt.AddPrompt(new Prompt("What was the Highlight of your day?"));
_prompt.AddPrompt(new Prompt("What What would you do differenly today?"));
_prompt.AddPrompt(new Prompt("Who was the best person you talk to today?"));
_prompt.AddPrompt(new Prompt("What should you have done better today?"));
_prompt.AddPrompt(new Prompt("How do you handle stress today?"));
_prompt.AddPrompt(new Prompt("Why do you like programming?"));
_prompt.AddPrompt(new Prompt("What could you change about your code?"));

Menu _menu = new Menu(_prompt);
_menu.Display();