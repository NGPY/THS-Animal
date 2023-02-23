# THS-Animal tutorial on how to commit to this repository
This is just a quick run down on how to commit to this repository as it is not possible to push straight to main.
# Notice: Please only commit changes to the Program.cs file, other changes cause conflicts
## Step 1.
Create a new branch for a feature you are working on

`git checkout -b New-Branch-Name-Here`
`git push -u origin New-Branch-Name-Here`

## Step 2. 
Use this branch to test and push new features without affecting the main branch. Only work in this branch until you are fully finished with a feature. 
### If using visual studio to interact with git:
Add the .gitignore file to make it so you do not commit unwanted files from your directory
![image](https://user-images.githubusercontent.com/78988335/220924050-9d88577d-8bd4-4e0c-bf96-3b384e87438a.png)

## Step 3.
When the feature is completed head over to pull requests in this repository you are currently working in.
![image](https://user-images.githubusercontent.com/78988335/220739635-3e34e192-6ae2-432d-aab8-451822d59e48.png)

## Step 4. 
Create a pull request with the base as Main and the compare as the branch you want to merge.
![image](https://user-images.githubusercontent.com/78988335/220740129-bd3543ba-3abd-424e-9caf-86bbfb543f9a.png)

## Step 5. 
When you create this pull request wait for another team member to review the code you want to merge to make sure it works as intended. And once you have gotten a
reply and the go ahead from another team member merge the branches and delete the old branch.
