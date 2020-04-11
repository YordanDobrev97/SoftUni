package core;

import model.File;
import model.SampleFile;
import org.junit.Test;
import shared.FileManager;

import java.util.List;

import static org.junit.Assert.*;

public class FileExplorerTest {

    @Test
    public void testConstructorShouldSetFileNumberToOne() {
        FileManager fileManager = new FileExplorer();
        File root = fileManager.getRoot();
        assertNotNull(root);
        assertEquals(1, root.getNumber());
    }

    @Test
    public void testContains() {
        FileManager fileManager = new FileExplorer();
        SampleFile file = new SampleFile(2, "second");
        fileManager.addInDirectory(1, file);
        boolean result = fileManager.contains(file);
        assertTrue(result);
    }

    @Test
    public void testMoveFile() {
        FileManager fileManager = new FileExplorer();
        SampleFile file = new SampleFile(2, "second");
        SampleFile secondFile = new SampleFile(3, "third");
        SampleFile fourFile = new SampleFile(4, "four");
        SampleFile fiveFile = new SampleFile(5, "five");

        fileManager.addInDirectory(1, file);
        fileManager.addInDirectory(2, secondFile);
        fileManager.addInDirectory(3, fourFile);
        fileManager.addInDirectory(3, fiveFile);

        fileManager.move(secondFile, file);
        assertEquals(3,  file.getChildren().size());
    }

    @Test
    public void testDeleteFile() {
        FileManager fileManager = new FileExplorer();
        SampleFile file = new SampleFile(2, "second");
        fileManager.addInDirectory(1, file);
        boolean result = fileManager.deleteFile(file);
        assertTrue(result);
    }

    @Test
    public void testDeleteFileWithAllChildren() {
        FileManager fileManager = new FileExplorer();
        SampleFile second = new SampleFile(2, "second");
        SampleFile third = new SampleFile(3, "third");
        SampleFile four = new SampleFile(4, "four");
        fileManager.addInDirectory(1, second);
        fileManager.addInDirectory(2, third);
        fileManager.addInDirectory(2, four);

        boolean result = fileManager.deleteFile(second);
        assertTrue(result);
    }

    @Test
    public void testCutFile() {
        FileManager fileManager = new FileExplorer();
        SampleFile file = new SampleFile(2, "second");
        fileManager.addInDirectory(1, file);
        fileManager.cut(2);
        assertEquals(0, fileManager.getRoot().getChildren().size());
    }

    @Test(expected = IllegalStateException.class)
    public void testThrowExceptionIfNotContainsDeleteFile() {
        FileManager fileManager = new FileExplorer();
        SampleFile file = new SampleFile(2, "second");
        fileManager.addInDirectory(1, file);

        boolean result = fileManager.deleteFile(new SampleFile(10, "not contains"));
    }

    @Test
    public void testGetFilesInPath() {
        FileManager fileManager = new FileExplorer();
        SampleFile file = new SampleFile(2, "second");
        SampleFile secondFile = new SampleFile(3, "third");
        SampleFile fourFile = new SampleFile(4, "four");
        SampleFile fiveFile = new SampleFile(5, "five");

        fileManager.addInDirectory(1, file);
        fileManager.addInDirectory(2, secondFile);
        fileManager.addInDirectory(3, fourFile);
        fileManager.addInDirectory(3, fiveFile);

        List<File> files = fileManager.getFilesInPath(secondFile);
        assertEquals(2, files.size());
    }

    @Test
    public void testGetInDepth() {
        FileManager fileManager = new FileExplorer();
        SampleFile file = new SampleFile(2, "second");
        SampleFile secondFile = new SampleFile(3, "third");
        SampleFile fourFile = new SampleFile(4, "four");
        SampleFile fiveFile = new SampleFile(5, "five");

        fileManager.addInDirectory(1, file);
        fileManager.addInDirectory(2, secondFile);
        fileManager.addInDirectory(3, fourFile);
        fileManager.addInDirectory(3, fiveFile);

        List<File> files = fileManager.getInDepth();
        assertEquals(4, files.size());
    }

    @Test
    public void testAddMultipleFilesAsString() {
        FileManager fileManager = new FileExplorer();
        for (int i = 1; i <= 23; i++) {
            File root = fileManager.getRoot();
            assertNotNull(root);
            fileManager.addInDirectory(root.getNumber(), new SampleFile(i, "test_name"));
        }

        String expected =
                "1\n" +
                        "├── 1\n" +
                        "├── 2\n" +
                        "├── 3\n" +
                        "├── 4\n" +
                        "├── 5\n" +
                        "├── 6\n" +
                        "├── 7\n" +
                        "├── 8\n" +
                        "├── 9\n" +
                        "├── 10\n" +
                        "├── 11\n" +
                        "├── 12\n" +
                        "├── 13\n" +
                        "├── 14\n" +
                        "├── 15\n" +
                        "├── 16\n" +
                        "├── 17\n" +
                        "├── 18\n" +
                        "├── 19\n" +
                        "├── 20\n" +
                        "├── 21\n" +
                        "├── 22\n" +
                        "└── 23";

        String result = fileManager.getAsString();
        System.out.println(result);
        assertEquals(expected.replaceAll("\n", System.lineSeparator()), result);
    }

    @Test
    public void testAddMultipleFiles() {
        FileManager fileManager = new FileExplorer();
        for (int i = 2; i <= 24; i++) {
            fileManager.addInDirectory(i - 1, new SampleFile(i, "test_name"));
        }
        String newLine = System.lineSeparator();
        assertEquals("1" + newLine +
                        "└── 2" + newLine +
                        "    └── 3" + newLine +
                        "        └── 4" + newLine +
                        "            └── 5" + newLine +
                        "                └── 6" + newLine +
                        "                    └── 7" + newLine +
                        "                        └── 8" + newLine +
                        "                            └── 9" + newLine +
                        "                                └── 10" + newLine +
                        "                                    └── 11" + newLine +
                        "                                        └── 12" + newLine +
                        "                                            └── 13" + newLine +
                        "                                                └── 14" + newLine +
                        "                                                    └── 15" + newLine +
                        "                                                        └── 16" + newLine +
                        "                                                            └── 17" + newLine +
                        "                                                                └── 18" + newLine +
                        "                                                                    └── 19" + newLine +
                        "                                                                        └── 20" + newLine +
                        "                                                                            └── 21" + newLine +
                        "                                                                                └── 22" + newLine +
                        "                                                                                    └── 23" + newLine +
                        "                                                                                        └── 24",

                fileManager.getAsString());
    }

    @Test
    public void testGetRoot() {
        FileManager fileManager = new FileExplorer();
        for (int i = 2; i <= 24; i++) {
            fileManager.addInDirectory(i - 1, new SampleFile(i, "test_name"));
        }
        // This method should always return 1
        // however if this only returns it without setting the correct
        // rule inside the constructor the rest tests will fail
        File root = fileManager.getRoot();

        assertNotNull(root);

        assertEquals(1, root.getNumber());
    }

    @Test
    public void testGetFileByKey() {
        FileManager fileManager = new FileExplorer();
        for (int i = 2; i <= 24; i++) {
            fileManager.addInDirectory(i - 1, new SampleFile(i, "test_name"));
        }
        File file = fileManager.get(13);
        assertNotNull(file);
        File prev = file;
        for (int i = 13; i <= 23; i++) {
            assertEquals(i, prev.getNumber());
            List<File> children = prev.getChildren();
            assertNotNull(children);
            assertEquals(1, children.size());
            prev = children.get(0);
        }
    }

    @Test
    public void testGetWithTwoEquals() {
        FileManager fileManager = new FileExplorer();
        fileManager.addInDirectory(1, new SampleFile(2, "test_name"));
        fileManager.addInDirectory(1, new SampleFile(3, "test_name"));
        fileManager.addInDirectory(1, new SampleFile(4, "test_name 4"));
        fileManager.addInDirectory(1, new SampleFile(4, "test_name 5"));
        File result = fileManager.get(4);
        assertEquals("test_name 4", result.getName());
    }

    @Test(expected = IllegalStateException.class)
    public void testGetFileByKeyShouldThrowWithInvalidKey() {
        FileManager fileManager = new FileExplorer();
        for (int i = 2; i <= 24; i++) {
            fileManager.addInDirectory(i - 1, new SampleFile(i, "test_name"));
        }
        fileManager.get(123);
    }

    @Test
    public void testGetAsString() {
        FileManager fileManager = new FileExplorer();
        fileManager.addInDirectory(1, new SampleFile(45, "test_name"));
        fileManager.addInDirectory(1, new SampleFile(84, "test_name"));
        fileManager.addInDirectory(1, new SampleFile(38, "test_name"));
        fileManager.addInDirectory(45, new SampleFile(10, "test_name"));
        fileManager.addInDirectory(45, new SampleFile(62, "test_name"));
        fileManager.addInDirectory(84, new SampleFile(59, "test_name"));
        fileManager.addInDirectory(59, new SampleFile(24, "test_name"));
        fileManager.addInDirectory(10, new SampleFile(49, "test_name"));
        fileManager.addInDirectory(49, new SampleFile(44, "test_name"));
        fileManager.addInDirectory(62, new SampleFile(80, "test_name"));
        fileManager.addInDirectory(62, new SampleFile(6, "test_name"));
        fileManager.addInDirectory(62, new SampleFile(91, "test_name"));
        fileManager.addInDirectory(80, new SampleFile(5, "test_name"));
        fileManager.addInDirectory(5, new SampleFile(6, "test_name"));
        fileManager.addInDirectory(80, new SampleFile(0, "test_name"));
        fileManager.addInDirectory(91, new SampleFile(65, "test_name"));

        String expected =
                "1\n" +
                        "├── 45\n" +
                        "│   ├── 10\n" +
                        "│   │   └── 49\n" +
                        "│   │       └── 44\n" +
                        "│   └── 62\n" +
                        "│       ├── 80\n" +
                        "│       │   ├── 5\n" +
                        "│       │   │   └── 6\n" +
                        "│       │   └── 0\n" +
                        "│       ├── 6\n" +
                        "│       └── 91\n" +
                        "│           └── 65\n" +
                        "├── 84\n" +
                        "│   └── 59\n" +
                        "│       └── 24\n" +
                        "└── 38";

        assertEquals(expected.replaceAll("\n", System.lineSeparator()), fileManager.getAsString());
    }
}