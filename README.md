# Lekeplass Kart Bergen

## Overview

A web application to display playgrounds (lekeplasser) in Bergen using Google Maps.

## Dataset

[Dataset taken from](https://github.com/datahotellet/dataset-archive/blob/main/datasets/bergen/lekeplasser/dataset.csv)

## Setup Guide

1. Clone repo

   ```bash
   git clone https://github.com/yourusername/lekeplass-kart-bergen.git
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
