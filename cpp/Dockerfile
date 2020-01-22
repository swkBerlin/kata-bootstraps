FROM debian:buster

LABEL maintainer = "Michele Adduci <adduci.michele@gmail.com>" \
  license = "MIT" \
  description = "Development Enviroment for C++"

RUN DEBIAN_FRONTEND=noninteractive \
  && echo "### Installing C++ tools" \
  && apt-get update \
  && apt-get -y install build-essential cmake \
  && echo "### Cleaning up" \
  && apt-get autoremove -y \
  && apt-get clean -y \
  && rm -rf /var/lib/apt/lists/* \
  && mkdir -p /project

WORKDIR /project
