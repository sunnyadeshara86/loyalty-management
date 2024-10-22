pipeline {
    agent any 

    stages {
        stage('Checkout') {
            steps {
                // Checkout the code from the repository
                git 'https://github.com/your-repo.git'
            }
        }
        stage('Restore Packages') {
            steps {
                // Restore NuGet packages
                sh 'dotnet restore YourSolution.sln'
            }
        }
        stage('Build') {
            steps {
                // Build the solution
                sh 'dotnet build YourSolution.sln --configuration Release'
            }
        }
        stage('Test') {
            steps {
                // Run the tests
                sh 'dotnet test YourSolution.sln --configuration Release'
            }
        }
        stage('Publish') {
            steps {
                // Publish each API project
                sh 'dotnet publish src/LoyaltyManagement.Achievement.Api.csproj --configuration Release --output ./publish/AchievementApi'
                sh 'dotnet publish src/LoyaltyManagement.Campaign.Api.csproj --configuration Release --output ./publish/CampaignApi'
            }
        }
    }

    post {
        success {
            echo 'Build, tests, and publish completed successfully!'
        }
        failure {
            echo 'Build or tests failed.'
        }
    }
}