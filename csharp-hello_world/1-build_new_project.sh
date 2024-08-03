#!/bin/bash

PROJECT_DIR="1-new_project"

mkdir -p $PROJECT_DIR

cd $PROJECT_DIR

dotnet new console

dotnet build
