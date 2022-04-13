<h1 align="center">
	<!-- <img alt="Logo" src=".github/logo.png" width="200px" /> -->
  .NET API to connect with Azure App Configuration
</h1>

<p align="center">

  <a href="https://www.linkedin.com/in/ana-carolina-ribeiro-santos/">
    <img alt="Made by" src="https://img.shields.io/badge/made%20by-Carolina%20Ribeiro-blue">
  </a>
  
  <img alt="GitHub" src="https://img.shields.io/badge/license-MIT-green">
</p>

## 👩🏻‍💻 About the project

- <p style="color: blue;">API to get the configuration value from the Azure app configuration.</p>

## 💻 Getting started

**Clone the project and access the folder**

```bash
$ git clone https://github.com/cahribeiro/AzureConfiguration.git && cd AzureConfiguration
```

**Follow the steps below**

```bash
# Configuration in Azure
create an App Configuration
add a KeyValue in App Configuration
in "Identity" options, switch Status to On and select Save.
in Access control (IAM), select Add > Add role assignment, on the Role tab, select the App Configuration Data Reader role. on the Members tab, select Managed identity, and then select Select members. Add your user.

#Configuration in project
in appsettings.json file, add the url from Azure App Configuration.
when running locally don't forget to put your Azure credentials in visual studio options.

```

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

Made with 💜 &nbsp;by Carolina Ribeiro 👋 &nbsp;[See my linkedin](https://www.linkedin.com/in/ana-carolina-ribeiro-santos/)
