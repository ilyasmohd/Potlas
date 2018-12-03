# Potlas
Potlas Tech solutions - Lab Programs
This repository contains all the sample programs that i used while teaching students at Potlas tech solutions.

To Delete a Branch from remote machine: 
$ git push --delete <remote_name> <branch_name>   ///for remote branch
$ git branch -d <branch_name>                     ///for local branch

example:
git push --delete https://github.com/ilyasmohd/Potlas.git Icomparer-Example

add new files in branch:
git add .
git commit -m "Add existing file"
git push origin your-branch

git config --global user.email "you@example.com"
git config --global user.name "Your Name"

git commit --allow-empty -m "Trigger rebuild"
git push

to override your local changes and get latest from branch.
git fetch origin
git reset --hard origin/HEAD
or
git checkout master
git branch new-branch-to-save-current-commits
git fetch --all
git reset --hard origin/master

https://dont-be-afraid-to-commit.readthedocs.io/en/latest/git/commandlinegit.html
