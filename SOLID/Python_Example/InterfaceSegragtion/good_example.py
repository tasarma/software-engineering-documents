# https://realpython.com/solid-principles-python/

from abc import ABC, abstractmethod

class Printer(ABC):
    @abstractmethod
    def print(self, document):
        pass

class Fax(ABC):
    @abstractmethod
    def fax(self, document):
        pass

class Scanner(ABC):
    @abstractmethod
    def scan(self, document):
        pass

class OldPrinter(Printer):
    def print(self, document):
        pass

class NewPrinter(Printer, Fax, Scanner):
    def print(self, document):
        pass

    def fax(self, document):
        pass

    def scan(self, document):
        pass
