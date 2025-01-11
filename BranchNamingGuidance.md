# Branch Naming Convention

To maintain consistency and clarity in our version control process, we adhere to the following branch naming convention. This ensures that branches are descriptive, organized, and easy to understand for everyone in the team.

---

## **Branch Naming Format**

```
s11/<type>/<summary_of_user_story>
```

### **Components**

1. **s11**

   - This represents the sprint number. Always prefix your branch name with `s11` to indicate the current sprint.

2.

   - This defines the purpose of the branch. Use one of the following keywords based on the task type:
     - `feature`: For new features being developed.
     - `bugfix`: For resolving bugs or issues.
     - `refactor`: For improving or restructuring existing code without changing its functionality.

3. **\<summary\_of\_user\_story>**

   - A concise summary or description of the task, reflecting the related user story or ticket. Use lowercase letters and separate words with underscores (`_`).

---

## **Examples**

### **Feature Branch**

For adding a new feature:

```
s11/feature/add_user_authentication
```

### **Bugfix Branch**

For fixing a bug related to login issues:

```
s11/bugfix/fix_login_error
```

### **Refactoring Branch**

For refactoring the database schema:

```
s11/refactor/improve_database_structure
```

---

## **Additional Guidelines**

1. **Be Descriptive:** Ensure the `summary_of_user_story` is brief but clearly conveys the purpose of the branch.
2. **Use Lowercase:** Use only lowercase letters in the branch name. Avoid spaces or special characters.
3. **Separate Words with Underscores:** Use underscores (`_`) to separate words in the summary for better readability.
4. **Avoid Long Names:** Keep the branch name concise to avoid difficulties during merges and pull requests.

---

## **Workflow with Branch Naming**

1. **Create a Branch:** Use the appropriate format to create your branch:

   ```bash
   git checkout -b s11/<type>/<summary_of_user_story>
   ```

2. **Push the Branch:** Push the branch to the remote repository:

   ```bash
   git push origin s11/<type>/<summary_of_user_story>
   ```

3. **Merge the Branch:** Ensure proper code reviews and testing before merging the branch back to the main branch.

---

By following this convention, we ensure better collaboration, easier navigation of branches, and a structured development process. If you have any questions or suggestions for improvement, feel free to discuss them with the team.

