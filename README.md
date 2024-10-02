<a name="readme-top"></a>

<div align="center">
  <h3 align="center">TestApi</h3>
  <p align="center">
    .NET Backend Developer Project
  </p>
</div>

<!-- TABLE OF CONTENTS -->

<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#about-the-project">About The Project</a></li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->

## About The Project

This project is a REST API project. It was developed with Onion Architecture.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->

## Getting Started

This project was developed with .NET 8. It also uses Microsoft SQL Server. Make sure you have the .NET 8 SDK and Microsoft SQL Server is running before using it.

Follow these simple steps to get a local copy up and running.

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/furkanyazar/TestApi
   ```
2. Change directory
   ```sh
   cd TestApi
   ```
3. Check the BaseDb connection string in `src/testApi/WebAPI/appsettings.json`
   ```json
   "ConnectionStrings": {
     "BaseDb": ""
   }
   ```
4. Update database
   ```sh
   dotnet ef database update --project src/testApi/Persistence --startup-project src/testApi/WebAPI
   ```
5. Run
   ```sh
   dotnet watch run --project src/testApi/WebAPI
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- USAGE EXAMPLES -->

## Usage

[Click here](docs/usage/README.MD) to go to the usage documentation.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTACT -->

## Contact

- Furkan Yazar - [furkanyazar.dev](https://furkanyazar.dev/) - [contact@furkanyazar.dev](mailto:contact@furkanyazar.dev)

Project Link: [https://github.com/furkanyazar/TestApi](https://github.com/furkanyazar/TestApi)

<p align="right">(<a href="#readme-top">back to top</a>)</p>
