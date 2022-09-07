{ pkgs ? import <nixpkgs> {} }:

with pkgs;

mkShell {
  buildInputs = [
    nodejs
    python310

    nodePackages.npm
    nodePackages.sass
  ];
}
