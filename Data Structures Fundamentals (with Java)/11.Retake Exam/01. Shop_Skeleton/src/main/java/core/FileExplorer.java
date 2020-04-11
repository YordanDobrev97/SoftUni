package core;

import model.File;
import shared.FileManager;
import java.util.List;
import java.util.ArrayList;
import model.SampleFile;

public class FileExplorer implements FileManager {
    private File root;
    public FileExplorer() {
        this.root = new SampleFile(1, "Root");
    }

    @Override
    public void addInDirectory(int directorNumber, File file) {
        if (this.root.getChildren().size() == 0) {
            List<File> children = new ArrayList<>();
            children.add(file);
            this.root.setGetChildren(children);
        } else {
            File currentFile = this.root;
            List<File> children = currentFile.getChildren();
            boolean isFound = false;
            while (currentFile.getNumber() != directorNumber) {
                List<File> childrenOfChildren = new ArrayList<>();
                for (File child : children) {
                   if (child.getNumber() == directorNumber) {
                       currentFile = child;
                       isFound = true;
                       break;
                   } else {
                       childrenOfChildren.addAll(child.getChildren());
                   }
                }

                if (isFound) {
                    break;
                }
                children = childrenOfChildren;
                if (children.size() == 0) {
                    throw new IllegalStateException("Not found");
                }
            }

            currentFile.getChildren().add(file);
        }
    }

    @Override
    public File getRoot() {
        return this.root;
    }

    @Override
    public File get(int number) {
        File currentFile = this.root;
        List<File> children = currentFile.getChildren();
        boolean isFound = false;
        while (currentFile.getNumber() != number) {
            List<File> childrenOfChildren = new ArrayList<>();
            for (File child : children) {
                if (child.getNumber() == number) {
                    currentFile = child;
                    isFound = true;
                    break;
                } else {
                    childrenOfChildren.addAll(child.getChildren());
                }
            }

            if (isFound) {
                break;
            }
            children = childrenOfChildren;
            if (children.size() == 0) {
                throw new IllegalStateException("Not found");
            }
        }

        return currentFile;
    }

    @Override
    public Boolean deleteFile(File file) {
        File currentFile = this.root;
        List<File> children = currentFile.getChildren();
        boolean isFound = false;
        File prevFile = null;
        while (currentFile.getNumber() != file.getNumber()) {
            List<File> childrenOfChildren = new ArrayList<>();
            prevFile = currentFile;
            for (File child : children) {
                if (child.getNumber() == file.getNumber()) {
                    currentFile = child;
                    isFound = true;
                    break;
                } else {
                    childrenOfChildren.addAll(child.getChildren());
                }
            }

            if (isFound) {
                break;
            }
            children = childrenOfChildren;
            if (children.size() == 0) {
                throw new IllegalStateException("Not found");
            }
        }

        if (prevFile != null) {
            prevFile.getChildren().remove(file);
            return true;
        }

        return false;
    }

    @Override
    public List<File> getFilesInPath(File path) {
        List<File> resultList = new ArrayList<>();
        File currentFile = this.root;
        List<File> children = currentFile.getChildren();
        boolean isFound = false;
        while (currentFile.getNumber() != path.getNumber()) {
            List<File> childrenOfChildren = new ArrayList<>();

            for (File child : children) {
                if (child.getNumber() == path.getNumber()) {
                    resultList.addAll(child.getChildren());
                    isFound = true;
                    break;
                } else {
                    childrenOfChildren.addAll(child.getChildren());
                }
            }

            if (isFound) {
                break;
            }
            children = childrenOfChildren;
            if (children.size() == 0) {
                throw new IllegalStateException("Not found");
            }
        }

        return resultList;
    }

    @Override
    public void move(File file, File destination) {
        List<File> children = file.getChildren();
        while (true) {
            List<File> nextChildren = new ArrayList<>();
            for (File child : children) {
                destination.getChildren().add(child);
                nextChildren.addAll(child.getChildren());
            }
            children = nextChildren;
            if (children.size() == 0) {
                break;
            }
        }
    }

    @Override
    public Boolean contains(File file) {
        File currentFile = this.root;
        List<File> children = currentFile.getChildren();
        boolean isFound = false;
        while (currentFile.getNumber() != file.getNumber()) {
            List<File> childrenOfChildren = new ArrayList<>();
            for (File child : children) {
                if (child.getNumber() == file.getNumber()) {
                    currentFile = child;
                    isFound = true;
                    break;
                } else {
                    childrenOfChildren.addAll(child.getChildren());
                }
            }

            if (isFound) {
                return true;
            }
            children = childrenOfChildren;
            if (children.size() == 0) {
                throw new IllegalStateException("Not found");
            }
        }
        return false;
    }

    @Override
    public List<File> getInDepth() {
        List<File> children = new ArrayList<>();
        List<File> current = this.getRoot().getChildren();
        while (true) {
            List<File> nextChildren = new ArrayList<>();
            for (File child : current) {
                children.add(child);
                nextChildren.addAll(child.getChildren());
            }
            current = nextChildren;
            if (current.size() == 0) {
                break;
            }
        }
        return children;
    }

    @Override
    public List<File> getInLevel() {
        return null;
    }

    @Override
    public void cut(int number) {
        File currentFile = this.root;
        List<File> children = currentFile.getChildren();
        boolean isFound = false;
        File prevFile = null;
        while (currentFile.getNumber() != number) {
            List<File> childrenOfChildren = new ArrayList<>();
            prevFile = currentFile;
            for (File child : children) {
                if (child.getNumber() == number) {
                    currentFile = child;
                    isFound = true;
                    break;
                } else {
                    childrenOfChildren.addAll(child.getChildren());
                }
            }

            if (isFound) {
                break;
            }
            children = childrenOfChildren;
            if (children.size() == 0) {
                throw new IllegalStateException("Not found");
            }
        }

        if (prevFile != null) {
            prevFile.getChildren().remove(currentFile);
        }
    }

    @Override
    public void paste(File destination) {

    }

    @Override
    public Boolean isEmpty() {
        return this.getRoot().getChildren().size() == 0;
    }

    @Override
    public String getAsString() {
        if (this.root == null) {
            return "";
        }
        StringBuilder buffer = new StringBuilder();
        print(this.root, buffer, "", "");
        return buffer.toString().trim();
    }

    private void print(File file, StringBuilder buffer, String prefix, String childrenPrefix) {
        buffer.append(prefix);
        buffer.append(file.getNumber());
        buffer.append(System.lineSeparator());
        List<File> children = file.getChildren();
        for (int i = 0; i < children.size(); i++) {
            File next = children.get(i);
            if (i < children.size() - 1) {
                print(next, buffer, childrenPrefix + "├── ", childrenPrefix + "│   ");
            } else {
                print(next, buffer, childrenPrefix + "└── ", childrenPrefix + "    ");
            }
        }
    }
}
