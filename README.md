# Log4OM-Utils

A collection of small tools designed to streamline and solve daily challenges for Log4OM users. These utilities aim to improve productivity and enhance the user experience when working with Log4OM in various environments.

## Tools

### Log4OM-Starter

**Log4OM-Starter** is a Windows Forms application built with .NET Framework 4.8. It is specifically designed for users of the portable version of Log4OM who operate across multiple computers.

![Log4OM-Starter Screenshot](https://s.l2m.io/ee35677f-2b12-403a-a7b8-bfa48023b4b3)

#### Key Features

- Simplifies the process of loading the latest Log4OM backup and configuration.
- Works seamlessly with cloud-synchronized folders (e.g., OneDrive, Dropbox, ProtonDrive).
- Allows users to quickly set up Log4OM on any computer with a single click.

#### Use Case

If you have configured automatic backups for Log4OM in a synchronized folder, **Log4OM-Starter** helps you restore the latest backup and configuration effortlessly. This is particularly useful when switching between multiple computers.

#### How It Works

**Log4OM-Starter** performs the following tasks:

1. Searches the backup folder for the latest SQLite database and JSON configuration file.
2. Copies these files to the operational directories of Log4OM specified by the user.
3. Updates the JSON configuration file to reflect user-defined paths, enabling Log4OM to function seamlessly across different computers without path conflicts.
   - Specifically, it updates the following JSON paths:
     - `UserConfigs.DbConfiguration.Path`
     - `UserConfigs.BackupFolder`
     - `UserConfigs.KeyerLastMacroFile`
4. Allows the user to save **Log4OM-Starter**'s configuration for future use, creating a `.l4om-starter` JSON file.
5. Ensures safety by backing up the existing SQLite database before overwriting it, appending the extension `.l4om-starter-backup`.
6. For convenience, renames the SQLite database to `db.sqlite` before transferring it to the operational directory.

This functionality ensures that users can easily switch between multiple computers while maintaining a consistent Log4OM setup.

---

## Requirements

- Windows Operating System
- .NET Framework 4.8
- Log4OM Portable Version
- A synchronized folder (e.g., OneDrive, Dropbox, ProtonDrive) for Log4OM backups and configuration files

## Installation

1. Download the latest release from the [Releases](#) section.
2. Extract the contents to a directory of your choice.
3. Ensure that Log4OM Portable and your synchronized backup folder are properly configured.
4. Run `Log4OM-Starter.exe`.

## Usage

1. Open **Log4OM-Starter**.
2. Select the location of your synchronized backup folder.
3. Click the "Load Latest Configuration" button.
4. Log4OM Portable will start with the most recent configuration and backup files.

## Contributing

Contributions are welcome! If you have ideas for additional tools or improvements, feel free to open an issue or submit a pull request. Please adhere to the [Code of Conduct](#) and follow the contribution guidelines.

## License

This project is licensed under the GNU General Public License v3.0. See the [LICENSE](#) file for details.
