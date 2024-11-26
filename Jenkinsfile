pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        script {
          bat 'dotnet build SW-const.sln'
        }
      }
    }
    stage('Docker Build') {
      steps {
        script {
          bat 'docker build -t sw-const-api .'
        }
      }
    }
    stage('Deploy to Staging') {
      steps {
        script {
          bat 'docker-compose up --build -d'
        }
      }
    }
  }
}
