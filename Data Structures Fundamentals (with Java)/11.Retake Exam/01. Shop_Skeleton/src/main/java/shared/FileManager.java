package shared;

import model.File;

import java.util.List;

public interface FileManager {
    void addInDirectory(int directorNumber, File file);
    File getRoot();
    File get(int number);
    Boolean deleteFile(File file);
    List<File> getFilesInPath(File path);
    void move(File file, File destination);
    Boolean contains(File file);
    List<File> getInDepth();
    List<File> getInLevel();
    void cut(int number);
    void paste(File destination);
    Boolean isEmpty();
    String getAsString();
}
