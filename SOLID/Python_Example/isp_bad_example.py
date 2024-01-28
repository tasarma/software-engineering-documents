# https://realpython.com/solid-principles-python/

from abc import ABC, abstractmethod

class Printer(ABC):
    @abstractmethod
    def print(self, document):
        pass

    @abstractmethod
    def fax(self, document):
        pass

    @abstractmethod
    def scan(self, document):
        pass

class OldPrinter(Printer):
    def print(self, document):
        pass

    def fax(self, document):
        pass

    def scan(self, document):
        pass

class ModernPrinter(Printer):
    def print(self, document):
        pass

    def fax(self, document):
        pass

    def scan(self, document):
        pass
