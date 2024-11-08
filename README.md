# Lekeplass Kart Bergen

## Overview

A web application to display playgrounds (lekeplasser) in Bergen using Google Maps.

## Dataset

[Dataset taken from](https://github.com/datahotellet/dataset-archive/blob/main/datasets/bergen/lekeplasser/dataset.csv)

## Setup Guide

1. Clone repo

   ```bash
   git clone https://github.com/eirikkar/lekeplass-kart-bergen.git
   cd lekeplass-kart-bergen

   ```

2. Initialize user secrets:

   ```bash
   dotnet user-secrets init
   ```

3. Set the Google Maps API key:

   ```bash
   dotnet user-secrets set "GoogleMapsApiKey" "YOUR_API_KEY"

   ```

## Usage

1.  Start the program:
    ```sh
    dotnet run
    ```
2.  Navigate to localhost:5025.

## Diagram

For a detailed overview of the program's architecture, please refer to the [diagram](/documentation/lekeplass.png).

## Notes

Ensure you have .NET installed on your machine.
