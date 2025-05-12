```markdown
# 🔄 AnaGrammer

**AnaGrammer** is a simple and interactive C# console application that checks whether two words or phrases are anagrams of each other. An anagram is a word or phrase formed by rearranging the letters of another, such as *listen* and *silent*.

---

## 🎯 Features

- Accepts any two words or phrases from the user
- Ignores spaces and case sensitivity
- Clearly displays whether the two inputs are anagrams
- Allows repeated checks in a loop until the user exits
- Clean console output with color-coded text for readability

---

## 🧠 How It Works

1. Prompts the user to enter two words or phrases.
2. Removes whitespace and converts input to lowercase.
3. Sorts the characters in both strings alphabetically.
4. Compares the sorted strings.
5. Returns `True` if they match (anagram), `False` otherwise.

---

## 💬 Sample Interaction

```

# WELCOME TO THE ANAGRAMMER

Enter your first word:

> listen

Enter your second word:

> silent
> \==============================

The result is....True

Would you like to continue? (y/n)

> n

Thank you for using ANAGRAMMER!!....Press any key

````

---

## 🛠️ Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (.NET 6.0 or later recommended)
- Compatible terminal or command line interface

---

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/AnaGrammer.git
````

2. Navigate into the project directory:

   ```bash
   cd AnaGrammer
   ```

3. Build and run the application:

   ```bash
   dotnet run
   ```

---

## 🧼 Possible Enhancements

* Support punctuation handling (e.g., ignoring special characters)
* Add support for multi-language character sets
* Count and display how many letters differ
* Build a GUI version using Windows Forms or WPF

---

## 👩‍💻 Author

**Hailey Jade Govender**
Enthusiastic software developer dedicated to writing clean and meaningful code.

---

## 📄 License

This project is licensed under the MIT License.
Feel free to use, modify, and distribute it for personal or educational use.

---
