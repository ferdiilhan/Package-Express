# Package-Express

# Package Express Shipping Calculator

A simple console application that calculates shipping quotes based on package dimensions and weight.

## Description

This C# console application helps users calculate shipping costs for their packages. The application takes into account:
- Package weight
- Package dimensions (width, height, length)
- Applies business rules for maximum weight and size limitations

## Features

- Weight validation (maximum 50 units)
- Dimension validation (total of width, height, and length must not exceed 50 units)
- Automatic quote calculation based on package specifications
- User-friendly console interface
- Clear error messages for invalid packages

## How to Use

1. Clone the repository:
```bash
git clone https://github.com/ferdiilhan/Package-Express.git
```

2. Navigate to the project directory:
```bash
cd Package-Express
```

3. Run the application:
```bash
dotnet run
```

4. Follow the prompts to enter:
   - Package weight
   - Package width
   - Package height
   - Package length

## Example Usage

```
Welcome to Package Express. Please follow the instructions below.
Please enter the package weight: 40
Please enter the package width: 10
Please enter the package height: 12
Please enter the package length: 11
Your estimated total for shipping this package is: $528.00
Thank you!
```

## Technical Requirements

- .NET 6.0 or higher
- Visual Studio Code or any C# compatible IDE

## Business Rules

1. Package weight must not exceed 50 units
2. Sum of dimensions (width + height + length) must not exceed 50 units
3. Shipping quote is calculated as: (width × height × length × weight) / 100

## Contact

- Developer: Ferdi Ilhan
- Email: Ferdi.Ilhan@my-aolcc.com
- GitHub: [ferdiilhan](https://github.com/ferdiilhan/)

## License

This project is licensed under the MIT License - see the LICENSE file for details.
