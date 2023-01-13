    private void flipLine(Direction direction, Brick brick, Color targetColor) {

        int x = brick.getXPosition();
        int y = brick.getYPosition();
        ArrayList<Coordinate> coordinates = new ArrayList<>();

        switch (direction) {
            case North:
                while (y > 0) {
                    y--;

                    if (this.board[x][y] == null) {
                        break;
                    }

                    if (this.board[x][y].getColor() != targetColor) {
                        for (Coordinate coordinate: coordinates) {
                            this.board[coordinate.getX()][coordinate.getY()].flip();
                        }
                        break;
                    }

                    coordinates.add(new Coordinate(x, y));
                }
                break;
            case South:
                while (y < 7) {
                    y++;

                    if(this.board[x][y] == null) {
                        break;
                    }

                    if(this.board[x][y].getColor() != targetColor) {
                        for (Coordinate coordinate: coordinates) {
                            this.board[coordinate.getX()][coordinate.getY()].flip();
                        }
                    }

                    coordinates.add(new Coordinate(x, y));
                }
                break;
            case East:
                while (x < 7) {
                    x++;

                    if(this.board[x][y] == null) {
                        break;
                    }

                    if(this.board[x][y].getColor() != targetColor) {
                        for (Coordinate coordinate: coordinates) {
                            this.board[coordinate.getX()][coordinate.getY()].flip();
                        }
                    }

                    coordinates.add(new Coordinate(x, y));
                }
                break;
            case West:
                while (x > 0) {
                    x--;

                    if(this.board[x][y] == null) {
                        break;
                    }

                    if(this.board[x][y].getColor() != targetColor) {
                        for (Coordinate coordinate: coordinates) {
                            this.board[coordinate.getX()][coordinate.getY()].flip();
                        }
                    }

                    coordinates.add(new Coordinate(x, y));
                }
                break;
            case NorthEast:
                while (y > 0 && x < 7) {
                    y--;
                    x++;

                    if(this.board[x][y] == null) {
                        break;
                    }

                    if(this.board[x][y].getColor() != targetColor) {
                        for (Coordinate coordinate: coordinates) {
                            this.board[coordinate.getX()][coordinate.getY()].flip();
                        }
                    }

                    coordinates.add(new Coordinate(x, y));
                }
                break;
            case NorthWest:
                while (y > 0 && x > 0) {
                    y--;
                    x--;

                    if(this.board[x][y] == null) {
                        break;
                    }

                    if(this.board[x][y].getColor() != targetColor) {
                        for (Coordinate coordinate: coordinates) {
                            this.board[coordinate.getX()][coordinate.getY()].flip();
                        }
                    }

                    coordinates.add(new Coordinate(x, y));
                }
                break;
            case SouthWest:
                while (y < 7 && x > 0) {
                    y++;
                    x--;

                    if(this.board[x][y] == null) {
                        break;
                    }

                    if(this.board[x][y].getColor() != targetColor) {
                        for (Coordinate coordinate: coordinates) {
                            this.board[coordinate.getX()][coordinate.getY()].flip();
                        }
                    }

                    coordinates.add(new Coordinate(x, y));
                }
                break;
            case SouthEast:
                while (y < 7 && x < 7) {
                    x++;
                    y++;

                    if(this.board[x][y] == null) {
                        break;
                    }

                    if(this.board[x][y].getColor() != targetColor) {
                        for (Coordinate coordinate: coordinates) {
                            this.board[coordinate.getX()][coordinate.getY()].flip();
                        }
                    }

                    coordinates.add(new Coordinate(x, y));
                break;
        }


    }

