{pkgs ? import <nixpkgs> {}}:
with pkgs;
  mkShell {
    buildInputs = [
      nodejs
      python311

      nodePackages.npm
      nodePackages.sass
    ];
  }
